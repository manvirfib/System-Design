Why Design Principles Matter

They help you:
1. Reduce coupling

2. Increase maintainability

3. Make change safer

4. Write testable, readable code

Note: For Liskov, if there is a Parent class A and Child Class B, then input/ output of B should be same as A, why?
Because assume client is using A type, example :
class userService{
    userService(A data){
        int num = 4/A;
    }
}
//client is assuming class A will return numbers greater than 1. but if we pass the derived class and it is
allowing the number to go even 0. Then there will be exception, hence,
We always need to maintain flow of A, that means if it throwing the error at certain times, child classes should
also throw them

Note: Client is only aware of the contract(A type) hence, client made or write the logic as per A. so don't break it.

In short::
The Key Idea 🔑

Child classes must not surprise the client.

If A guarantees something, B must guarantee it too.

One-Line Mental Model 🧠

1. Client says: “Give me anything that behaves like A”

2. Child says: “I promise to behave exactly like A”

3. If that promise is broken → LSP violation