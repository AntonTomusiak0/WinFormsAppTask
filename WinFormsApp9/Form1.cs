namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public ToolStripMenuItem topitem = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            string topLevelName = TopLevelMenu.Text;
            if (!string.IsNullOrEmpty(topLevelName))
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(topLevelName);
                menuStrip1.Items.Add(menuItem);
                topitem = menuItem;
            }
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            string subName = SubItem.Text;
            if (!string.IsNullOrEmpty(subName))
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(subName);
                topitem.DropDownItems.Add(menuItem);
            }
        }
    }
}
