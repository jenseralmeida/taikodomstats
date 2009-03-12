using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using TaikodomStats.Controls;
using TaikodomStats.DataSL;
using System.Globalization;
//using TaikodomStats.Db4o;

namespace TaikodomStats
{
    public partial class CareerSimulatorPage : UserControl
    {
        
        public CareerSimulatorPage()
        {
            InitializeComponent();
            bindSkillPointGridTimer = new DispatcherTimer {Interval = new TimeSpan(0, 0, 0, 0, 10)};
            bindSkillPointGridTimer.Tick += BindSkillPointGridTimer_Tick;
            ddlLang.Items.Add("PT");
            ddlLang.Items.Add("EN");
            ddlLang.SelectedIndex = CultureInfo.CurrentCulture.ToString() == "pt-BR" ? 0 : 1;
            MontarGlobal(ddlLang.SelectedIndex == 0);
            cbxCarreira.ItemsSource = Career.GetAll(ddlLang.SelectedIndex == 0);

            new MouseWheelUtil(skillScroll).Moved += delegate(object sender, MouseWheelEventArgs e)
            {
                const int scrollOffsetVariation = 30;
                e.Handled = true;
                
                if (e.Delta > 0)
                    skillScroll.ScrollToVerticalOffset(skillScroll.VerticalOffset - scrollOffsetVariation);
                else
                    skillScroll.ScrollToVerticalOffset(skillScroll.VerticalOffset + scrollOffsetVariation);
            };

        }

        private void MontarGlobal(bool pt)
        {
            if (pt)
            {
                ddlLang.SelectedIndex = 0;
                tbxCareer.Text = "Carreira";
                tbxAvaibles.Text = "Pontos Disponíveis: ";
                tbxTotal.Text = "Total de Pontos: ";
                tbxUsed.Text = "Pontos Usados: ";
                tbxOferecimento.Text = "Oferecimento:";
            }
            else
            {
                ddlLang.SelectedIndex = 1;
                tbxCareer.Text = "Career";
                tbxAvaibles.Text = "Avaibles Points: ";
                tbxTotal.Text = "Total Points: ";
                tbxUsed.Text = "Used Points: ";
                tbxOferecimento.Text = "Brought to you by:";
            }
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
            #warning DEBUG: Não compila
            //var cli = new DB4OProxyServiceClient("BasicHttpBinding_IDB4OProxyService");
            //cli.GetDatabaseAsync();
            

        }

        private void SkillPointMark_Click(object sender, RoutedEventArgs e)
        {
            var control = (Control)sender;
            var skillPoint = (SkillPoint)control.DataContext;
            var containsSkillPoint = CurrentSimulator.IsLastUsedSkillPoint(skillPoint);
            if (!containsSkillPoint)
            {
                CurrentSimulator.SetSkillPoint(skillPoint);
            }
            else
            {
                CurrentSimulator.DecrementSkillPoint(skillPoint.Skill);
            }
        }

        private void ddlLang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MontarGlobal(ddlLang.SelectedIndex == 0);
            cbxCarreira.ItemsSource = Career.GetAll(ddlLang.SelectedIndex == 0);
        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            // bug in tolltip http://silverlight.net/forums/p/51002/133858.aspx#133858
            // datacontext is null, getting from button
            //var dt = Resources["individualSkillPointAvaliable"] as DataTemplate;
         //   if (btn != null) ((TextBlock) sender).DataContext = btn.DataContext;
        }

        private void FullScreen_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Host.Content.IsFullScreen = !Application.Current.Host.Content.IsFullScreen;
            
        }
    }
}