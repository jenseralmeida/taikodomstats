using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using TaikodomStats.DataSL;
using System.Collections;
using System.Windows.Markup;

namespace SimuladorCarreira
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            _DispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            _DispatcherTimer.Tick += new EventHandler(_DispatcherTimer_Tick);
            BuildAll();
        }

        private void CheckSetup()
        {
            gvwSkills.Focus();
            _DispatcherTimer.Start();
        }

        private readonly System.Windows.Threading.DispatcherTimer _DispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private void _DispatcherTimer_Tick(object sender, EventArgs e)
        {
            _DispatcherTimer.Stop();
            gvwSkills.Columns.Clear();
            gvwSkills.ItemsSource = null;
            gvwSkills.ItemsSource = inter;
            GerarColunas();
        }

        private readonly List<CareerSimulator> simulator = new List<CareerSimulator>();
        
        public void GerarColunas()
        {
            var nomeSkill = new DataGridTextColumn
                                {
                                    Width = new DataGridLength(155),
                                    Header = "Skill",
                                    Binding = new Binding("Skill.Name")
                                };
            gvwSkills.Columns.Add(nomeSkill);
            for (var i = 0; i < 15; i++)
            {
                var botaoTemplate = new DataGridTemplateColumn
                                        {
                                            Width = new DataGridLength(29),
                                            CellTemplate = ((DataTemplate)Resources["ButtonSK" + (i + 1).ToString()])
                                        };
                gvwSkills.Columns.Add(botaoTemplate);
            }

        }

        readonly List<Interface> inter = new List<Interface>();
        private void cbxCarreira_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxCarreira == null) return;
            var carreira = (Career)cbxCarreira.SelectedItem;
            // motando carreira
            simulator.Clear();
            simulator.Add(new CareerSimulator("Testando", carreira));
            if (carreira.Name == "Ás")
            {
                //simulator[0].IncrementSkillPoint(carreira.Skills[0]);
                //simulator[0].IncrementSkillPoint(carreira.Skills[1]);
                //simulator[0].IncrementSkillPoint(carreira.Skills[2]);
            }
            
            //atualizando indicador de pontos restantes
            tbxPoint.Text = (carreira.TotalPoints - simulator[0].NumberOfUsedSkillPoints).ToString();
            // montando skillpointsbyskill
            var q = from Skill s in carreira.Skills
                     let k = carreira.GetSkillPoints(s)
                     select new { s, k };
            var grids = new List<SkillPointsBySkill>();
            foreach (var sk in q)
            {
                grids.Add(new SkillPointsBySkill(sk.s, sk.k));
            }
            // montando interface
            inter.Clear();
            foreach (var s in grids)
            {
                inter.Add(new Interface(s.Skill, (s.SkillPoints.Count() > 0) ? s.SkillPoints[0] : null, (s.SkillPoints.Count() > 1) ? s.SkillPoints[1] : null,
                    (s.SkillPoints.Count() > 2) ? s.SkillPoints[2] : null, (s.SkillPoints.Count() > 3) ? s.SkillPoints[3] : null,
                    (s.SkillPoints.Count() > 4) ? s.SkillPoints[4] : null, (s.SkillPoints.Count() > 5) ? s.SkillPoints[5] : null,
                    (s.SkillPoints.Count() > 6) ? s.SkillPoints[6] : null, (s.SkillPoints.Count() > 7) ? s.SkillPoints[7] : null,
                    (s.SkillPoints.Count() > 8) ? s.SkillPoints[8] : null, (s.SkillPoints.Count() > 9) ? s.SkillPoints[9] : null,
                    (s.SkillPoints.Count() > 10) ? s.SkillPoints[10] : null, (s.SkillPoints.Count() > 11) ? s.SkillPoints[11] : null,
                    (s.SkillPoints.Count() > 12) ? s.SkillPoints[12] : null, (s.SkillPoints.Count() > 13) ? s.SkillPoints[13] : null,
                    (s.SkillPoints.Count() > 14) ? s.SkillPoints[14] : null));
            }
            //gvwSkills.Columns.Clear();
            CheckSetup();
            //gvwSkills.ItemsSource = inter;
            //GerarColunas();
        }

        private void gvwSkills_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            //if (e.Row.GetIndex() == 2)
            //{
            //    var btn = GetChild<ToggleButton>(gvwSkills.Columns[3].GetCellContent(e.Row)) as ToggleButton;
            //}
        }

        private void btnSK_Checked(object sender, RoutedEventArgs e)
        {
            if (((ToggleButton)sender).MinHeight != 1)
            {
                var ok = simulator[0].IncrementSkillPoint(((SkillPoint) ((ToggleButton) sender).Tag).Skill);
                if (!ok)
                {
                    //((ToggleButton)sender).IsChecked = false;
                    return;
                }
                ((ToggleButton) sender).Background = new SolidColorBrush(Colors.Red);
                // pog para controlar ckeck do botao (nao podia testar usando a ischecked pois o evento eh chekED)
                ((ToggleButton)sender).MinHeight = 1;
                var carreira = (Career) cbxCarreira.SelectedItem;
                //atualizando indicador de pontos restantes
                tbxPoint.Text = (carreira.TotalPoints - simulator[0].NumberOfUsedSkillPoints).ToString();
            }
            //else
            //{
            //    ((ToggleButton)sender).IsChecked = false;
            //}
        }

        private void btnSK_Unchecked(object sender, RoutedEventArgs e)
        {
            if (((ToggleButton)sender).MinHeight == 1)
            {
                var ok = simulator[0].DecrementSkillPoint(((SkillPoint) ((ToggleButton) sender).Tag).Skill);
                if (!ok)
                {
                    //((ToggleButton)sender).IsChecked = true;
                    return;
                }
                ((ToggleButton) sender).Background = new SolidColorBrush(Colors.Gray);
                // pog para controlar ckeck do botao (nao podia testar usando a ischecked pois o evento eh chekED)
                ((ToggleButton)sender).MinHeight = 2;
                var carreira = (Career) cbxCarreira.SelectedItem;
                //atualizando indicador de pontos restantes
                tbxPoint.Text = (carreira.TotalPoints - simulator[0].NumberOfUsedSkillPoints).ToString();
            }
            //else
            //{
            //    ((ToggleButton)sender).IsChecked = true;
            //}
        }

        private void btnSK1_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        //public T GetChild<T>(DependencyObject obj) where T : DependencyObject
        //{
        //    DependencyObject child = null;
        //    for (var i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
        //    {
        //        child = VisualTreeHelper.GetChild(obj, i);
        //        if (child != null && child.GetType() == typeof(T))
        //        {
        //            break;
        //        }
        //        else if (child != null)
        //        {
        //            child = GetChild<T>(child);
        //            if (child != null && child.GetType() == typeof(T))
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    return child as T;
        //}

        private void BuildAll()
        {
            if (System.Globalization.CultureInfo.CurrentCulture.ToString() != "pt-BR")
            {
                tbxCarreira.Text = "Career:";
            }
            cbxCarreira.ItemsSource = InstanciateData.GetCareers();        }
    }
}
