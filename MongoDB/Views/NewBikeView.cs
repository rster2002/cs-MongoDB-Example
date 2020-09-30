using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace MongoDB.Views {
    public partial class NewBikeView: UserControl {
        private BikeRepo bikeRepo = new BikeRepo();
        public event EventHandler<Bike> bikeAddedEvent;

        public NewBikeView() {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void confirmNewBikeButtonOnClick(object sender, EventArgs e) {
            string modelName = bikeModelNameTextBox.Text;
            Bike bike = new Bike() {
                model = modelName
            };

            bikeRepo.add(bike);

            bikeAddedEvent.Invoke(this, bike);
        }
    }
}
