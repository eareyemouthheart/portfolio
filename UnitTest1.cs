using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Test addToTail()
        public void addToTail()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToTail(n1); // 1
            dL.addToTail(n2); // 1 3
            dL.addToTail(n3); // 1 3 5
            Assert.AreEqual(dL.head.num, 1); //1
            Assert.AreEqual(dL.tail.num, 5); //5
        }




        [TestMethod]
        // Test addToHead()
        public void addToHead()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); // 1
            dL.addToHead(n2); // 3 1
            dL.addToHead(n3); // 5 3 1
            Assert.AreEqual(dL.head.num, 5); //5
            Assert.AreEqual(dL.tail.num, 1); //1
        }




        [TestMethod]
        //Test removeHead()-------------------list is not null
        public void removeHead()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); // 1
            dL.addToHead(n2); // 3 1
            dL.addToHead(n3); // 5 3 1
            dL.removeHead(); // 3 1
            Assert.AreEqual(dL.head.num, 3); // 3
            Assert.AreEqual(dL.tail.num, 1); // 1
        }




        [TestMethod]
        //Test removeHead()------------------------ test as if the list have only one node
        public void removeHeadOne()
        {
            DLList dL = new DLList();
            dL.addToHead(new DLLNode(3)); // 3
            dL.removeHead(); // null
            dL.removeHead(); // null
            Assert.AreEqual(dL.head, null); // null
            Assert.AreEqual(dL.tail, null); // null
        }




        [TestMethod]
        // Test removeHead()------------------------ test as if the list is empty
        public void removeHeadEmp()
        {
            DLList newDLL = new DLList();
            newDLL.removeHead(); // null
            Assert.AreEqual(newDLL.head, null); // null
            Assert.AreEqual(newDLL.tail, null); // null
        }



        [TestMethod]
        // test removeTail()
        public void removeTail()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToTail(n1); // 1
            dL.addToTail(n2); // 1 3
            dL.addToTail(n3); // 1 3 5
            dL.removeHead(); // 3 5
            Assert.AreEqual(dL.head.num, 3); // 3
            Assert.AreEqual(dL.tail.num, 5); // 5
        }



        [TestMethod]
        // test removeTail()---------------------list have only one node
        public void removeTailOne()
        {
            DLList dL = new DLList();
            dL.addToHead(new DLLNode(3)); // 3
            dL.removeTail(); // null
            dL.removeTail(); // null
            Assert.AreEqual(dL.head, null); // null
            Assert.AreEqual(dL.tail, null); // null
        }



        [TestMethod]
        // test removeTail()---------------------list empty
        public void removeTailEmp()
        {
            DLList dL = new DLList();
            dL.removeTail(); // null
            Assert.AreEqual(dL.head, null); // null
            Assert.AreEqual(dL.tail, null); // null
        }




        [TestMethod]
        // DLLNode search(int num)
        public void search()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); // 1
            dL.addToHead(n2); // 3 1
            dL.addToHead(n3); // 5 3 1
            Assert.AreEqual(dL.search(1).num, 1); // search 1 return 1
            Assert.AreEqual(dL.search(3).num, 3); // return3
        }




        [TestMethod]
        // DLLNode search(int num)------------------list in null
        public void searchNull()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); // 1
            dL.addToHead(n2); // 3 1
            dL.addToHead(n3); // 5 3 1
            Assert.AreEqual(dL.search(8), null);// return null
        }




        [TestMethod]
        //removeNode---------------------------------moving head node in the list
        public void removeNodeHead()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); //1
            dL.addToHead(n2); //3 1
            dL.addToHead(n3); //5 3 1
            dL.removeNode(n3); //3 1
            Assert.AreEqual(dL.head.num, 3);// 3
            Assert.AreEqual(dL.tail.num, 1);//1
        }


        [TestMethod]
        //removeNode---------------------------------moving node between the head and tail
        public void removeNodeMiddle()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); //1
            dL.addToHead(n2); //3 1
            dL.addToHead(n3); //5 3 1
            dL.removeNode(n2); //5 1
            Assert.AreEqual(dL.head.num, 5);// 5
            Assert.AreEqual(dL.tail.num, 1);//1
        }





        [TestMethod]
        //removeNode---------------------------------removing tail in the list
        public void removeNodeTail()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); //1
            dL.addToHead(n2); //3 1
            dL.addToHead(n3); //5 3 1
            dL.removeNode(n1); //5 3
            Assert.AreEqual(dL.head.num, 5);// 5
            Assert.AreEqual(dL.tail.num, 3);//3
        }








        [TestMethod]
        // removeNode ----------one node on the list
        public void removeNodeEmptyList()
        {
            DLLNode n1 = new DLLNode(1);
            DLList dL = new DLList();
            dL.removeNode(n1); // null
            Assert.AreEqual(dL.head, null); //  NULL
            Assert.AreEqual(dL.tail, null); // NULL
        }





        [TestMethod]
        // removeNode--------------no node in the list
        public void removeNodeNull()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); // 1
            dL.addToHead(n2); // 3 1
            dL.addToHead(n3); // 5 3 1
            dL.removeNode(new DLLNode(8)); // 5 3 1
            Assert.AreEqual(dL.head.num, 5); // HEAD
            Assert.AreEqual(dL.tail.num, 1); // TAIL 
        }






        [TestMethod]
        // test total()------------------with not null list
        public void total()
        {
            DLList dL = new DLList();
            DLLNode n1 = new DLLNode(1);
            DLLNode n2 = new DLLNode(3);
            DLLNode n3 = new DLLNode(5);
            dL.addToHead(n1); // 1
            dL.addToHead(n2); // 3 1
            dL.addToHead(n3); // 5 3 1
            Assert.AreEqual(dL.total(), 3); // total = 3
        }





        [TestMethod]
        // test total() -----------with  empty list
        public void totalEmpty()
        {
            DLList dL = new DLList();
            Assert.AreEqual(dL.total(), 0); // total = 0
        }










        [TestMethod]
        //test with correct value 
        public void IsPrimeTrue()
        {
            DLLNode n1 = new DLLNode(7);

            Assert.IsTrue(n1.isPrime(n1.num));// TRUE
        }





        [TestMethod]
        //Testing isPrime 
        public void IsPrimeProblem()
        {
            DLLNode n1 = new DLLNode(2);
            DLLNode n2 = new DLLNode(1);
            DLLNode n3 = new DLLNode(-7);

            Assert.IsTrue(n1.isPrime(n1.num));//true
            Assert.IsFalse(n2.isPrime(n2.num));//f
            Assert.IsFalse(n3.isPrime(n3.num));//f
        }

        [TestMethod]
        // incorrect value 
        public void IsPrimeFalse()
        {
            DLLNode n2 = new DLLNode(10);

            Assert.IsFalse(n2.isPrime(n2.num));
            //Fixed < to <=
        }
    }
}