using CL_Lepidoptere;

namespace ConsoleLepidoptere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere lepidoptereA = new Lepidoptere();
            lepidoptereA.SeMetamorphoser();
            lepidoptereA.SeDeplacer();
        }
    }
}