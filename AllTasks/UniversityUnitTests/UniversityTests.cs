﻿using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class UniversityTests
    {           
        [TestMethod]
        public void CheckAddEmployeeForUniversityPositive()
        {
            Rector rector = new(
                "N1",
                "Anton",
                "Antonov",
                "Doctor",
                "Professor");

            University university = new(
                rector,
                new LegalAddress("220-051", "Minsk", "Vaneeva", 15),
                new List<UniversityEmployee> { rector },
                new());

            Teacher employee1 = new(
               "N2",
               "Maxim",
               "Maximov",
               new("Math", "Calculations"),
               "Doctor",
               "Professor");

            university.AddEmployee(employee1);
            Assert.AreEqual(university.Employees[1], employee1);                      
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "An duplicate employee was inappropriately allowed.")]
        public void CheckAddEmployeeForUniversityNegative()
        {
            Rector rector = new(
                "N1",
                "Anton",
                "Antonov",
                "Doctor",
                "Professor");

            University university = new(
                rector,
                new LegalAddress("220-051", "Minsk", "Vaneeva", 15),
                new List<UniversityEmployee> { rector },
                new());

            university.AddEmployee(rector);
            university.Employees[1].ToString();
        }

        [TestMethod]
        public void ChechAddEmployeeWithSameIdButDifRolesPositive()
        {
            Rector rector = new(
                "N1",
                "Anton",
                "Antonov",
                "Doctor",
                "Professor");

            University university = new(
                rector,
                new LegalAddress("220-051", "Minsk", "Vaneeva", 15),
                new List<UniversityEmployee> { rector },
                new());

            Teacher employee2 = new(
                "N1", //same as rector's
                "Anton",
                "Antonov",
                new("Math", "Calculations"),
                "Doctor",
                "Professor");

            university.AddEmployee(employee2);
            Assert.AreEqual(university.Employees[1], employee2);
        }

        [TestMethod]
        public void CheckAddBuildingForUniversityPositive()
        {
            University university = new(
                new Rector("N1", "Anton", "Antonov", "Math", "Calculations"),
                new LegalAddress("220-051", "Minsk", "Vaneeva", 15),
                new(),
                new());

            Building building1 = new("Building", "11111", new("City", "Street", 1), new());

            university.AddBuilding(building1);
            Assert.AreEqual(university.Buildings[0], building1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "An duplicate building was inappropriately allowed.")]
        public void CheckAddBuildingForUniversityNegative()
        {
            var building1 = new Building("Building", "11111", new("City", "Street", 1), new());

            var buildingList = new List<Building>
            {
            building1
            };

            University university = new(
                new Rector("N1", "Anton", "Antonov", "Math", "Calculations"),
                new LegalAddress("220-051", "Minsk", "Vaneeva", 15),
                new(),
                buildingList);

            var building2 = building1;

            university.AddBuilding(building2);
            university.Buildings[1].ToString();
        }

    }
}
