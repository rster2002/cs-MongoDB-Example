using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;
using MongoDB.Components;

namespace MongoDB.Views {
    public partial class DashboardView: UserControl {
        private BikeRepo bikeRepo = new BikeRepo();

        public DashboardView() {
            InitializeComponent();
            populateView();
        }

        private void populateView() {
            Controls.Clear();
            IEnumerable<Bike> bikes = bikeRepo.getAll();

            foreach (Bike bike in bikes) {
                bikePanel.Controls.Add(new BikeBox(bike));
            }
        }

        private void addBikeButtonOnClick(object sender, EventArgs e) {
            Form form = new Form();
            NewBikeView newBikeView = new NewBikeView();

            newBikeView.bikeAddedEvent += new EventHandler<Bike>((a, b) => form.Close());

            form.Controls.Add(newBikeView);
            form.Show();
        }
    }
}
