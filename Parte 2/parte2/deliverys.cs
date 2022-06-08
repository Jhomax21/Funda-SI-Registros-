namespace parte2
{
    public class deliverys
    {
        private string vehiculo;
        private string precio;

        public string Vehiculo { get => vehiculo; set => vehiculo = value; }
        public string Precio { get => precio; set => precio = value; }
        public deliverys(string vehiculo, string precio)
        {
            this.vehiculo = vehiculo;
            this.precio = precio;
        }
    }
}
