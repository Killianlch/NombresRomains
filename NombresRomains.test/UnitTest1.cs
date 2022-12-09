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

        [Fact]
        public void Test2()
        {
            //ETANT DONNE le nombre 2
            const int nombreArabe = 2;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(2);

            //ALORS on obtient 'II'
            Assert.Equal("II", resultat);
        }

        [Fact]
        public void Test3()
        {
            //ETANT DONNE le nombre 3
            const int nombreArabe = 3;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(3);

            //ALORS on obtient 'III'
            Assert.Equal("III", resultat);
        }
        [Fact]
        public void Test4()
        {
            //ETANT DONNE le nombre 4
            const int nombreArabe = 4;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(4);

            //ALORS on obtient 'IV'
            Assert.Equal("IV", resultat);
        }
        [Fact]
        public void Test5()
        {
            //ETANT DONNE le nombre 5
            const int nombreArabe = 5;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(5);

            //ALORS on obtient 'V'
            Assert.Equal("V", resultat);
        }
        [Fact]
        public void Test6()
        {
            //ETANT DONNE le nombre 6
            const int nombreArabe = 6;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(6);

            //ALORS on obtient 'VI'
            Assert.Equal("VI", resultat);
        }
        [Fact]
        public void Test7()
        {
            //ETANT DONNE le nombre 7
            const int nombreArabe = 7;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(7);

            //ALORS on obtient 'VII'
            Assert.Equal("VII", resultat);
        }
        [Fact]
        public void Test8()
        {
            //ETANT DONNE le nombre 8
            const int nombreArabe = 8;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(8);

            //ALORS on obtient 'VIII'
            Assert.Equal("VIII", resultat);
        }

        [Fact]
        public void Test9()
        {
            //ETANT DONNE le nombre 9
            const int nombreArabe = 9;

            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(9);

            //ALORS on obtient 'IX'
            Assert.Equal("IX", resultat);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void UnDeuxTrois(int n)
        {
            //ETANT DONNER un nombre <n> compris entre 1 et 5
            //QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            //ALORS on obtient <n> fois 'I'
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void CinqSixSeptHuit (int nombreArabe)
        {
            //ETANT DONNER un nombre <nombreArabe> compris entre 5 et 8 

            //QUAND on le convertit en nombre romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);
            // ALORS on obtient 'V' plus <nombreArabe> -5> fois 'I'
            var attendu = 'V' + new string('I', nombreArabe - 5);
        }
         
    }
}