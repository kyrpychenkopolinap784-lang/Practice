using AbstractFactory.TaxiAFactory.ALevel;
using AbstractFactory.TaxiAFactory.Uklon;
using AbstractFactory.TaxiAFactory.Uber;
using AbstractFactory.TaxiAFactory.Bolt;
using System;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class fTaxi : Form
    {
        //fields
        private string taxiType = null;

        private ITaxiFactory taxiFactory;
        private IEstate estate;
        private ISedan sedan;
        private IMPV mpv;

        //properties
        private IEstate Estate
        {
            get => estate;
            set
            {
                if (value != null)
                {
                    pbxEstate.Image = value.Appearance;
                    lbEstate.Text = value.TaxiType;
                }

                estate = value;
            }
        }
        private ISedan Sedan
        {
            get => sedan;
            set
            {
                if (value != null)
                {
                    pbxSedan.Image = value.Appearance;
                    lbSedan.Text = value.TaxiType;
                }

                sedan = value;
            }
        }
        private IMPV MPV
        {
            get => mpv;
            set
            {
                if (value != null)
                {
                    pbxMPV.Image = value.Appearance;
                    lbMPV.Text = value.TaxiType;
                }

                mpv = value;
            }
        }

        public fTaxi()
        {
            InitializeComponent();
        }

        //methods
        private void rbTaxiType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb && rb.Checked)
            {
                switch (rb.Text)
                {
                        case "Uklon":
                            taxiFactory = new UklonTaxiFactory();
                            break;
                        case "Bolt":
                            taxiFactory = new BoltTaxiFactory();
                            break;
                        case "Uber":
                            taxiFactory = new UberTaxiFactory();
                            break;
                        default:
                            taxiFactory = null;
                            break;
                    
                }
            }
        }

        private void rbTaxi_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                taxiType = rb.Text;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(taxiFactory == null || taxiType == null)
            {
                MessageBox.Show("Please select a taxi type and a taxi.");
                return;
            }

            switch(taxiType)
            {
                case "Estate":
                    Estate = taxiFactory.CreateEstate();
                    break;
                case "Sedan":
                    Sedan = taxiFactory.CreateSedan();
                    break;
                case "MPV":
                    MPV = taxiFactory.CreateMPV();
                    break;

                default:
                    MessageBox.Show("Unknown taxi type.");
                    return;
            }
        }
    }
}
