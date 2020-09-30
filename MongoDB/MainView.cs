﻿using MongoDB.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDB {
    public partial class MainView: Form {
        public MainView() {
            InitializeComponent();
            changeView(new DashboardView());
        }

        public void changeView(UserControl userControll) {
            viewContainer.Controls.Clear();
            userControll.Dock = DockStyle.Fill;

            viewContainer.Controls.Add(userControll);
        }
    }
}
