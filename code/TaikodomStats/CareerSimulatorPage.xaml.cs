using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading;
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
            bindSkillPointGridTimer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 0, 0, 10) };
            bindSkillPointGridTimer.Tick += BindSkillPointGridTimer_Tick;
            SetUpCulture();
            ChangeCulture();

            new MouseWheelUtil(skillScroll).Moved += SkillScroll_MouseWheelMoved;
        }

        private void SetUpCulture()
        {
            ddlLang.Items.Add("pt-BR");
            ddlLang.Items.Add("en-US");
            ddlLang.SelectedIndex = CultureInfo.CurrentCulture.ToString() == "pt-BR" ? 0 : 1;
        }

        private void SkillScroll_MouseWheelMoved(object sender, MouseWheelEventArgs e)
        {
            const int scrollOffsetVariation = 30;
            e.Handled = true;

            if (e.Delta > 0)
                skillScroll.ScrollToVerticalOffset(skillScroll.VerticalOffset - scrollOffsetVariation);
            else
                skillScroll.ScrollToVerticalOffset(skillScroll.VerticalOffset + scrollOffsetVariation);
        }

        private void MountUILocalized(bool pt)
        {
            string cultureName;
            if (pt)
            {
                cultureName = "pt-BR";
                ddlLang.SelectedIndex = 0;
                tbxCareer.Text = "Carreira";
                tbxAvaibles.Text = "Pontos Disponíveis: ";
                tbxTotal.Text = "Total de Pontos: ";
                tbxUsed.Text = "Pontos Usados: ";
                tbxOferecimento.Text = "Oferecimento:";
            }
            else
            {
                cultureName = "en-US";
                ddlLang.SelectedIndex = 1;
                tbxCareer.Text = "Career";
                tbxAvaibles.Text = "Avaibles Points: ";
                tbxTotal.Text = "Total Points: ";
                tbxUsed.Text = "Used Points: ";
                tbxOferecimento.Text = "Brought to you by:";
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);
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
            LayoutRoot.DataContext = null;
            // wait 10 ms to current row lost focus and call BindSkillPointGridTimer_Tick to finalize data bind
            bindSkillPointGridTimer.Start();
        }

        #endregion Bug in DataGrid: http://silverlight.net/forums/p/36559/109249.aspx#109249

        private void BindSkillPointGridTimer_Tick(object sender, EventArgs e)
        {
            bindSkillPointGridTimer.Stop(); //Bug in DataGrid: http://silverlight.net/forums/p/36559/109249.aspx#109249
            LayoutRoot.DataContext = null;
            var career = (Career)cbxCarreira.SelectedItem;
            LayoutRoot.DataContext = new CareerSimulator("Test", career);
            // DEBUG: Bug in ComboBox http://silverlight.net/forums/t/66350.aspx. UpdateLayout must be call before new set to SelectedIndex, so no DataBinding
            cbxRank.Items.Clear();
            foreach (var rank in (from r in career.Ranks orderby r.RankNumber descending select r))
            {
                cbxRank.Items.Add(rank);
            }
            cbxRank.UpdateLayout();
            cbxRank.SelectedIndex = 0;
        }

        private void SkillPointMark_Click(object sender, RoutedEventArgs e)
        {
            var control = (Control)sender;
            var skillPoint = (SkillPoint)control.DataContext;
            var containsSkillPoint = CurrentSimulator.IsLastUsedSkillPoint(skillPoint);
            if (!containsSkillPoint)
            {
                CurrentSimulator.SetSkillPoint(skillPoint, ((Rank) cbxRank.SelectedItem).RankNumber);
            }
            else
            {
                CurrentSimulator.DecrementSkillPoint(skillPoint.Skill);
            }
        }

        private void ddlLang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeCulture();
        }

        private void ChangeCulture()
        {
            MountUILocalized(ddlLang.SelectedIndex == 0);
            cbxCarreira.ItemsSource = Career.GetAll();
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            // DEBUG: Bug in tolltip http://silverlight.net/forums/p/46539/160825.aspx#160825 datacontext is null, getting from button
            var t = ToolTipService.GetToolTip(sender as Button) as ToolTip;
            if (t != null)
            {
                t.DataContext = ((Button)sender).DataContext;
            }
        }

        private void Rank_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if  (CurrentSimulator == null)
            {
                return;
            }
            var rankCombo = (ComboBox)sender;
            var rank = (Rank)rankCombo.SelectedItem;
            if (rank != null)
            {
                CurrentSimulator.CurrentRank = rank;
            }
        }
    }   
}