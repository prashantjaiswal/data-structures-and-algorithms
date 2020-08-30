using DataStructuresAlgorithms.StacksQueues;
using Xunit;

namespace Test_Data_Structure_Algorithms
{
    public class TestStacks
    {
        [Fact]
        public void TestStacksLinkedListPush()
        {
            var stack = new StacksLinkedList<string>();
            var firstPush = stack.Push("Google");

            Assert.Matches(stack.top.value, firstPush.value);
            Assert.Matches(stack.bottom.value, firstPush.value);

            var secondPush = stack.Push("Stackoverflow");
            Assert.Matches(stack.top.value, secondPush.value);
            Assert.True(stack.bottom.value != secondPush.value);


            var thirdPush = stack.Push("medium blog");
            Assert.Matches(stack.top.value, thirdPush.value);
            Assert.True(stack.bottom.value != thirdPush.value);
        }

        [Fact]
        public void TestStacksLinkedListPop()
        {
            var stack = new StacksLinkedList<string>();
            var firstPush = stack.Push("Google");
            var secondPush = stack.Push("Stackoverflow");
            var thirdPush = stack.Push("medium blog");

            var pop1 = stack.Pop();
            Assert.True(pop1.value == "medium blog");

            var pop2 = stack.Pop();
            Assert.True(pop2.value == "Stackoverflow");

            var pop3 = stack.Pop();
            Assert.True(pop3.value == "Google");
        }

        [Fact]
        public void TestStackArrayPush()
        {
            var stack = new StacksArray<string>(5);

            var firstPush =stack.Push("Google");
            Assert.Matches(firstPush, stack.Peek());

            var secondPush = stack.Push("StackOverflow");
            Assert.Matches(secondPush, stack.Peek());

            var thirdPush = stack.Push("Discord");
            Assert.Matches(thirdPush, stack.Peek());
        }

        [Fact]
        public void TestStackArrayPop()
        {
            var stack = new StacksArray<string>(5);

            var firstPush = stack.Push("Google");
            var secondPush = stack.Push("StackOverflow");
            var thirdPush = stack.Push("Discord");

            Assert.Matches(thirdPush, stack.Pop());
            Assert.Matches(secondPush, stack.Pop());
            Assert.Matches(firstPush, stack.Pop());
        }
    }
}
