using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoctorOffice.Models;
using System.Collections.Generic;
using System;

namespace DoctorOffice.Tests
{
//   [TestClass]
//   public class ClientTest : IDisposable
//   {
//
//     public void Dispose()
//     {
//       Client.ClearAll();
//     }
//
//     public ClientTest()
//     {
//       DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=jared_farkas_test;";
//     }
//
//   [TestMethod]
//    public void GetAll_CategoriesEmptyAtFirst_List()
//    {
//      //Arrange, Act
//      int result = Stylist.GetAll().Count;
//
//      //Assert
//      Assert.AreEqual(0, result);
//    }
//
//    [TestMethod]
//     public void GetAll_CategoriesNotEmpty_List()
//     {
//       //Arrange, Act
//       Client test = new Client("Test",1);
//       test.Save();
//       int result = Client.GetAll().Count;
//
//       //Assert
//       Assert.AreEqual(1, result);
//     }
//     [TestMethod]
//      public void GetClients_NoClients_List()
//      {
//        //Arrange, Act
//        Client test = new Client("Test",1);
//        test.Save();
//        int result = Client.GetClients(2).Count;
//
//        //Assert
//        Assert.AreEqual(0, result);
//      }
//      [TestMethod]
//       public void GetClients_SomeClientsNotAll_List()
//       {
//         //Arrange, Act
//         Client test = new Client("Test",1);
//         Client test2 = new Client("Test",4);
//         test.Save();
//         test2.Save();
//         int result = Client.GetClients(1).Count;
//
//         //Assert
//         Assert.AreEqual(1, result);
//       }
//   }
// }
//
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using System;
// using HairSalon.Models;
//
// namespace HairSalon.Tests
// {
//   [TestClass]
//   public class StylistTests : IDisposable
//   {
//     public void Dispose()
//     {
//       Stylist.ClearAll();
//       Client.ClearAll();
//     }
//
//     public StylistTests()
//     {
//       DBConfiguration.ConnectionString = "server=localhost;user id=root;port=3306;database=reese_lee_test;";
//     }
//
//    [TestMethod]
//    public void GetAll_StylistsEmptyAtFirst_0()
//    {
//      //Arrange, Act
//      int result = Stylist.GetAll().Count;
//
//      //Assert
//      Assert.AreEqual(0, result);
//    }
//
//     [TestMethod]
//     public void Equals_ReturnsTrueIfNamesAreTheSame_Stylist()
//     {
//       //Arrange, Act
//       Stylist firstStylist = new Stylist("Lizzy Ding", "blow-drying", 2);
//       Stylist secondStylist = new Stylist("Lizzy Ding", "hair-cutting", 2);
//
//       //Assert
//       Assert.AreEqual(firstStylist, secondStylist);
//     }
//
//     [TestMethod]
//     public void Save_SavesStylistToDatabase_StylistList()
//     {
//       //Arrange
//       Stylist testStylist = new Stylist("Joanna Fang", "hair-styling", 2);
//       testStylist.Save();
//
//       //Act
//       List<Stylist> result = Stylist.GetAll();
//       List<Stylist> testList = new List<Stylist> { testStylist };
//
//       //Assert
//       CollectionAssert.AreEqual(testList, result);
//     }
//
//      [TestMethod]
//      public void Save_DatabaseAssignsIdToStylist_Id()
//      {
//        //Arrange
//        Stylist testStylist = new Stylist("Charissa Laryx", "blow-drying", 3);
//        testStylist.Save();
//
//        //Act
//        Stylist savedStylist = Stylist.GetAll()[0];
//
//        int result = savedStylist.Id;
//        int testId = testStylist.Id;
//
//        //Assert
//        Assert.AreEqual(testId, result);
//     }
//
//     [TestMethod]
//     public void Find_FindsStylistInDatabase_Stylist()
//     {
//       //Arrange
//       Stylist testStylist = new Stylist("Opal Juicy", "hair-dying", 2);
//       testStylist.Save();
//
//       //Act
//       Stylist foundStylist = Stylist.Find(testStylist.Id);
//
//       //Assert
//       Assert.AreEqual(testStylist, foundStylist);
//     }
//
//     [TestMethod]
//     public void GetClients_RetrievesAllClientsWithStylist_ClientList()
//     {
//         //Arrange, Act
//         Stylist testStylist = new Stylist("Vanna Hiroi", "hair-styling", 4);
//         testStylist.Save();
//         Client firstClient = new Client("Ned Good", testStylist.Id);
//         firstClient.Save();
//         Client secondClient = new Client("Frannie Hernandez", testStylist.Id);
//         secondClient.Save();
//         List<Client> testClientList = new List<Client> { firstClient, secondClient };
//         List<Client> resultClientList = testStylist.GetClients();
//
//         //Assert
//         CollectionAssert.AreEqual(testClientList, resultClientList);
//     }

  // }
}
