using Microsoft.VisualStudio.TestTools.UnitTesting;
using RowingAutomation;

namespace RowingTests.TrainingTests
{
    [TestClass]
    public class SearchTraining : RowingTest
    {
        [TestMethod]
        public void CanSearchTraining()
        {
            TrainingListPage.GoTo();
            NewTrainingPage.GoTo();
            NewTrainingPage.CreateTraining("CanSearchTraining Test").WithDate("28.08.2016").Publish();
            TrainingListPage.SearchForTraining("CanSearchTraining Test");
            TrainingListPage.FindAndOpenTraining("CanSearchTraining Test").WithDate("28.08.2016").Open();

            Assert.AreEqual(TrainingDetailsPage.TrainingName, "CanSearchTraining Test", "Title did not match");
            Assert.AreEqual(TrainingDetailsPage.TrainingDate, "2016-08-28", "Date did not match");

            //cleanup
            TrainingListPage.GoTo();
            TrainingListPage.FindAndDeleteTraining("CanSearchTraining Test").WithDate("28.08.2016").Delete();
        }
    }
}
