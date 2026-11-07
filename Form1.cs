namespace predicate_tuplas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTuplas_Click(object sender, EventArgs e)
        {
            int r, y;
            int[] x;


            int[] numeros = { 5, 3, 76, 9 };
            (r, x, y) = Suma(numeros, 6);
            MessageBox.Show($"R={r},X={x},Y={y}");
        }
        private (int, int[], int) Suma(int[] a, int b)
        {
            int res = 0;

            foreach (int numeracion in a)
            {
                res = res + numeracion;
            }

            return (res, a, b);
        }

        private void btnPredicate_Click(object sender, EventArgs e)
        {
            Predicate<int> esPar = x => x % 2 == 0;
            Predicate<int> esPositivo = x => x > 0;

            int miNumero = Convert.ToInt32(txtNumero.Text);

            bool resultado1 = esPar(miNumero);
            MessageBox.Show(resultado1.ToString());

            List<int> denominacion = new List<int>();
            denominacion.Add(15);
            denominacion.Add(22);
            denominacion.Add(30);
            denominacion.Add(11);
            denominacion.Add(5);
            denominacion.Add(60);
            denominacion.Add(9);

            List<int> numerosPares = denominacion.FindAll(esPar);
            numerosPares.ForEach(x => MessageBox.Show(x.ToString()));
        }
    }
}
