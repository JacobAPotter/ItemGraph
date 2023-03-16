using System.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemGraph
{
    public partial class ItemGraph : Form
    {
        XmlDocument doc;

        public ItemGraph()
        {
            InitializeComponent();
        }

        private void ItemGraph_Load(object sender, EventArgs e)
        {
            doc = new XmlDocument();
            doc.LoadXml("ItemGraph.xml");

            XmlNodeList planetNodes = doc.SelectNodes("//Planet");

            foreach (XmlNode planetNode in planetNodes)
                planetBox.Items.Add(planetNode.SelectSingleNode("name").InnerText);
        }
    }
}
