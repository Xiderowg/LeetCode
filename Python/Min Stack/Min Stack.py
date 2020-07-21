class MinStack:

    def __init__(self):
        self.minStack, self.dataStack = [], []

    def push(self, x):
        if len(self.minStack) == 0:
            self.minStack.append(x)
        else:
            self.minStack.append(min(self.minStack[-1], x))
        self.dataStack.append(x)

    def pop(self):
        self.minStack.pop()
        self.dataStack.pop()

    def top(self):
        return self.dataStack[-1]

    def getMin(self):
        return self.minStack[-1]

# Your MinStack object will be instantiated and called as such:
# obj = MinStack()
# obj.push(x)
# obj.pop()
# param_3 = obj.top()
# param_4 = obj.getMin()
