using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void ItemConstructor_CreatsInstanceOfItem_Item()
        {
            Item newItem = new Item();
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description == "Walk the dog.";
            Item newItem = newItem(description);
            string result = newItem.Description;
            Assert.AreEqual(description, result);
        }
    }
}