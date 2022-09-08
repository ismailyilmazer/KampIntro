namespace DamaDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         Button[,] buttons=new Button[8,8];

           for( int i=0;i<buttons.GetUpperBound(0);i++)
            {
                for(int j=0;j<buttons.GetUpperBound(1);j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i,j].Width = 5;
                    buttons[i,j].Height = 5;
                    buttons[i, j].Left = Left;
                    buttons[i,j].Top = Top;
                    this.Controls.Add(buttons[i,j]);
                }
                Left = Left + 5;
                Top = Top + 5;

            }
            

           
        }
    }
}