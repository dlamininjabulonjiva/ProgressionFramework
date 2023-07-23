const person = {
    name: "John",
    greet: function() {
      console.log(`Hello, my name is ${this.name}`);
    },
};
  
person.greet(); // Output should be: Hello, my name is John