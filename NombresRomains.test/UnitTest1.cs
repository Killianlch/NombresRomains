namespace NombresRomains.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //ETANT DONNE le nombre 1
            const int nombreArabe = 1;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(1);

            //ALORS on obtient 'I'
            Assert.Equal("I", resultat);
        }
        public void Test2()
        {
            //ETANT DONNE le nombre 2
            const int nombreArabe = 2;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(2);

            //ALORS on obtient 'II'
            Assert.Equal("II", resultat);
        }
    }
}