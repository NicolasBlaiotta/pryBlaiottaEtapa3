namespace pryBlaiottaEtapa3
{
    public partial class Form1 : Form
    {
        ClsVehiculo objVehiculo;
        public Form1()
        {
            InitializeComponent();
            objVehiculo = new ClsVehiculo();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            objVehiculo.crearVehiculo(pctVehiculo, lblNombreVehiculo, lblTipoVehiculo);
        }
    }
}