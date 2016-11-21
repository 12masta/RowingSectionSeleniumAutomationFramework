using Microsoft.VisualStudio.TestTools.UnitTesting;
using RowingAutomation;

namespace RowingTests
{
    [TestClass]
    public class CreateNewTraining : RowingTest
    {
        [TestMethod]
        public void CanCreateNewTraining()
        {
            TrainingListPage.GoTo();
            NewTrainingPage.GoTo();
            NewTrainingPage.CreateTraining("Nowy trening").WithDate("11.08.2016").Publish();
            TrainingListPage.GoTo();
            TrainingListPage.FindAndOpenTraining("Nowy trening").WithDate("11.08.2016").Open();

            Assert.AreEqual(TrainingDetailsPage.TrainingName, "Nowy trening", "Title did not match");
            Assert.AreEqual(TrainingDetailsPage.TrainingDate, "2016-08-11", "Date did not match");

            //cleanup
            TrainingListPage.GoTo();
            TrainingListPage.FindAndDeleteTraining("Nowy trening").WithDate("11.08.2016").Delete();
        }
    }
}
