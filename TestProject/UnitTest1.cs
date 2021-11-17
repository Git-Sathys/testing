using Application.models;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void ServeurEqual0()
        {
            // Arrange
            Serveur serveur = new Serveur();
            serveur.ChiffreAffaire = 0;
            // Act
            int ca = serveur.ChiffreAffaire;
            // Assert
            Assert.Equal(0, ca);
        }
        [Fact]
        public void ServeurEqual()
        {
            // Arrange
            Serveur serveur = new Serveur();
            serveur.Commande = 0;
            serveur.ChiffreAffaire = 0;
            // Act
            int ca = serveur.ChiffreAffaire;
            int cc = serveur.Commande;
            // Assert
            Assert.Equal(cc, ca);
        }
        [Fact]
        public void ServeurSumCommand()
        {
            // Arrange
            Serveur serveur = new Serveur();
            var sc1 = serveur.Commande = 1;
            var sc2 = serveur.Commande = 2;
            // Act
            var sum = sc1 + sc2;
            var ca = sum;
            // Assert
            Assert.Equal(ca, sum);
        }
    }
}
