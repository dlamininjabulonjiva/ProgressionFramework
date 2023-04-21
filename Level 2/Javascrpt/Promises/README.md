# Promises
- Promises in JavaScript are a powerful feature that enables you to work with asynchronous operations and handle their results in an elegant way.
- A Promise is a special object that represents the eventual completion (or failure) of an asynchronous operation and provides a way to handle its outcome in a more organized and expressive way.
- Promises can be chained together using the then() method to handle the result of a previous Promise or the catch() method to handle any errors that occur in the Promise chain.
- Promises can also be used in combination with async/await syntax to create more readable and concise code.

# Promises have three states:
	1. Pending: The initial state of a Promise. The operation is not yet complete and the Promise is still waiting for the result.
	2. Fulfilled: The Promise has been resolved successfully and a value is available.
	3. Rejected: The Promise has been rejected with an error or exception and no value is available.
	
In this example(Nextjs App), I'm creating a new Promise that wraps the fetch call. I then use the .then() and .catch() methods to handle successful and failed Promise results.
If the Promise is rejected, I'm passing the error object to the reject function.
If the Promise resolves successfully, I'm mapping the response data to an array of User objects and passing it to the resolve function.
Then I display the users on the screen.

