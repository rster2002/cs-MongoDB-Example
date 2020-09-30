using Model;
using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDB.Components {
    class BikeBox : GroupBox {
        private Bike bike;

        public BikeBox(Bike bike) {
            this.bike = bike;

            populateComponent();
        }

        private void populateComponent() {
            Text = bike.model;

            // Create a detailList and add keyValue items
            ListView detailList = createDetailList();
            detailList.Items.Add(createKeyValueListItem("Id", bike.id));

            // Add the list to the BikeBox
            Controls.Add(detailList);
            Controls.Add(createDeleteButton());
        }

        private ListView createDetailList() {
            // Create a list that will contain the details of the bike
            ListView listView = new ListView();

            // Set the basic properties
            listView.Dock = DockStyle.Top;
            listView.View = View.Details;

            // Create the columns
            ColumnHeader keyHeader = new ColumnHeader();
            ColumnHeader valueHeader = new ColumnHeader();

            // Configure the columns
            keyHeader.Text = "Key";
            keyHeader.Width = 85;

            valueHeader.Text = "Value";
            valueHeader.Width = 85;

            // Add the columns to the listView
            listView.Columns.Add(keyHeader);
            listView.Columns.Add(valueHeader);

            return listView;
        }

        private ListViewItem createKeyValueListItem(string key, string value) {
            // Create a listViewItem and add the value as a subitem
            ListViewItem item = new ListViewItem(key);
            item.SubItems.Add(value);

            return item;
        }

        private Button createDeleteButton() {
            Button button = new Button();

            button.Text = "Delete";
            button.Click += new EventHandler((sender, b) => {
                
            });

            return button;
        }
    }
}
