using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxLingua_SelectedIndexChanged(object sender, EventArgs e)
        {
            MontarCarreira(cbxLingua.SelectedIndex == 1);
            pnlCoisas.Visible = false;
        }

        private void MontarCarreira(bool pt)
        {            
            cbxCarreira.Items.Clear();
            cbxCarreira.Items.Add(".:: Selecione um Item ::.");
            cbxCarreira.Items.Add(pt ? "Caça" : "HotShot");
            cbxCarreira.Items.Add(pt ? "Explorador" : "Scout");
            cbxCarreira.Items.Add(pt ? "Demolidor" : "Juggernaut");
            cbxCarreira.Items.Add(pt ? "Cargueiro" : "Merchant");
            cbxCarreira.SelectedIndex = 0;
            lblCarreira.Text = pt ? "Carreira:" : "Careers";

            lblCarreira.Visible = true;
            cbxCarreira.Visible = true;
        }

        private void MontarCaca(bool pt)
        {
            pnlCoisas.Visible = true;
            lblPilotagem.Text = pt ? "Pilotagem: Caça" : "Pilotage : HotShot";
            lblPilotagem.Visible = true;
            label1.Text = pt ? "Artilharia: Gauss" : "Artillery : Gauss";
            label1.Visible = true;
            label2.Text = pt ? "Artilharia: Magnética" : "Artillery : Magnetic";
            label2.Visible = true;
            label3.Text = "AfterBurn";
            label3.Visible = true;
            label4.Text = pt ? "Artilharia: Rail" : "Artillery : Rail";
            label4.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
            label1.Text = pt ? "Artilharia: Gaus" : "Artillery : Gaus";
            label1.Visible = true;
        }

        private void MontarExplorador(bool pt)
        {
            pnlCoisas.Visible = true;
            lblPilotagem.Text = pt ? "Pilotagem: Explorador" : "Pilotage : Scout";
            lblPilotagem.Visible = true;
        }

        private void MontarDemolidor(bool pt)
        {
            pnlCoisas.Visible = true;
            lblPilotagem.Text = pt ? "Pilotagem: Demolidor" : "Pilotage : Juggernaut";
            lblPilotagem.Visible = true;
        }

        private void MontarMercador(bool pt)
        {
            pnlCoisas.Visible = true;
            lblPilotagem.Text = pt ? "Pilotagem: Cargueiro" : "Pilotage : Merchant";
            lblPilotagem.Visible = true;
        }

        private void cbxCarreira_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = ((ComboBox)sender).SelectedIndex;
            if (i == 1)
                MontarCaca(cbxLingua.SelectedIndex == 1);
            if (i == 2)
                MontarExplorador(cbxLingua.SelectedIndex == 1);
            if (i == 3)
                MontarDemolidor(cbxLingua.SelectedIndex == 1);
            if (i == 4)
                MontarMercador(cbxLingua.SelectedIndex == 1);
        }
    }
}
