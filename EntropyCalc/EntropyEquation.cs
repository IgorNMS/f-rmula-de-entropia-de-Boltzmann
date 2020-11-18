namespace EntropyCalc
{
    public class EntropyEquation
    {
        public decimal Equation()
        {
            MicroStates microEstados;
            microEstados = new MicroStates();

            BoltzmanConst boltzmanConst;
            boltzmanConst = new BoltzmanConst();

            decimal Constante = boltzmanConst.Constant();
            decimal Estates = microEstados.MicroEstados();
            
            return Constante * Estates;
        }
    }
}