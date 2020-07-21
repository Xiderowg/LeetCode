# not cheating
class MyStack:

    def __init__(self):
        """
        Initialize your data structure here.
        """
        self.queueHead, self.queueTail = [], []

    def push(self, x: int) -> None:
        """
        Push element x onto stack.
        """
        self.queueHead.append(x)

    def pop(self) -> int:
        """
        Removes the element on top of the stack and returns that element.
        """
        for i in range(len(self.queueHead)-1):
            self.queueTail.append(self.queueHead.pop(0))
        val = self.queueHead.pop(0)
        self.queueHead = self.queueTail
        self.queueTail = []
        return val

    def top(self) -> int:
        """
        Get the top element.
        """
        for i in range(len(self.queueHead)-1):
            self.queueTail.append(self.queueHead.pop(0))
        val = self.queueHead.pop(0)
        self.queueTail.append(val)
        self.queueHead = self.queueTail
        self.queueTail = []
        return val

    def empty(self) -> bool:
        """
        Returns whether the stack is empty.
        """
        return len(self.queueHead) == 0


# Your MyStack object will be instantiated and called as such:
# obj = MyStack()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.top()
# param_4 = obj.empty()

# cheating
class MyStack:

    def __init__(self):
        """
        Initialize your data structure here.
        """
        self.stack = []

    def push(self, x: int) -> None:
        """
        Push element x onto stack.
        """
        self.stack.append(x)

    def pop(self) -> int:
        """
        Removes the element on top of the stack and returns that element.
        """
        return self.stack.pop()

    def top(self) -> int:
        """
        Get the top element.
        """
        return self.stack[-1]

    def empty(self) -> bool:
        """
        Returns whether the stack is empty.
        """
        return len(self.stack) == 0


# Your MyStack object will be instantiated and called as such:
# obj = MyStack()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.top()
# param_4 = obj.empty()
