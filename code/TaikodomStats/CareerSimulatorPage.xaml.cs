using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;
using TaikodomStats.DataSL;

namespace TaikodomStats
{
    public partial class CareerSimulatorPage : UserControl
    {
        
        public CareerSimulatorPage()
        {
            InitializeComponent();
            bindSkillPointGridTimer = new DispatcherTimer {Interval = new TimeSpan(0, 0, 0, 0, 10)};
            bindSkillPointGridTimer.Tick += BindSkillPointGridTimer_Tick;
            cbxCarreira.ItemsSource = Career.GetAll();
        }

        public CareerSimulator CurrentSimulator
        {
            get
            {
                return LayoutRoot.DataContext as CareerSimulator;   
            }
        }

        #region Bug in DataGrid: http://silverlight.net/forums/p/36559/109249.aspx#109249

        private readonly DispatcherTimer bindSkillPointGridTimer;

        private void cbxCarreira_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bug in DataGrid: http://silverlight.net/forums/p/36559/109249.aspx#109249
            skillPointsGrid.Focus();
            // wait 10 ms to current row lost focus and call BindSkillPointGridTimer_Tick to finalize data bind
            bindSkillPointGridTimer.Start();
        }

        private void BindSkillPointGridTimer_Tick(object sender, EventArgs e)
        {
            bindSkillPointGridTimer.Stop();
            LayoutRoot.DataContext = null;
            BindSelectedCareer();
        }

        #endregion Bug in DataGrid: http://silverlight.net/forums/p/36559/109249.aspx#109249

        private void BindSelectedCareer()
        {
            var career = cbxCarreira.SelectedItem as Career;
            LayoutRoot.DataContext = new CareerSimulator("Test", career);
        }


        private void SkillPointMark_Click(object sender, RoutedEventArgs e)
        {
            var control = (Control)sender;
            var skillPoint = (SkillPoint)control.DataContext;
            bool containsSkillPoint = CurrentSimulator.IsLastUsedSkillPoint(skillPoint);
            if (!containsSkillPoint)
            {
                CurrentSimulator.SetSkillPoint(skillPoint);
            }
            else
            {
                CurrentSimulator.DecrementSkillPoint(skillPoint.Skill);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            teste.Text = "fudeu!";
        }
    }
}