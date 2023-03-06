class Person {
    constructor(name, age) {
      this.name = name;
      this.age = age;
      this.friends = [];
    }
  
    greet() {
      return `Hello, my name is ${this.name} and I am ${this.age} years old.`;
    }
  
    addFriend(friend) {
      if (this.friends.indexOf(friend) === -1) {
        this.friends.push(friend);
        friend.addFriend(this);
      }
    }
  
    removeFriend(friend) {
      const index = this.friends.indexOf(friend);
      if (index !== -1) {
        this.friends.splice(index, 1);
        friend.removeFriend(this);
      }
    }
  
    introduce() {
      const friendNames = this.friends.map(friend => friend.name).join(', ');
      const intro = `My name is ${this.name} and I am ${this.age} years old. `;
      if (friendNames) {
        return intro + `My friends are ${friendNames}.`;
      } else {
        return intro + 'I have no friends.';
      }
    }
  }
  
  const john = new Person('John', 30);
  const mary = new Person('Mary', 25);
  const bob = new Person('Bob', 35);
  
  john.addFriend(mary);
  mary.addFriend(bob);
  bob.addFriend(john);
  
  console.log(john.introduce()); // output: "My name is John and I am 30 years old. My friends are Mary, Bob."
  console.log(mary.introduce()); // output: "My name is Mary and I am 25 years old. My friends are Bob, John."
  console.log(bob.introduce()); // output: "My name is Bob and I am 35 years old. My friends are John, Mary."
  console.log("");
  
  john.removeFriend(mary);
  
  console.log(john.introduce()); // output: "My name is John and I am 30 years old. My friends are Bob."
  console.log(mary.introduce()); // output: "My name is Mary and I am 25 years old. My friends are Bob."
  console.log(bob.introduce()); // output: "My name is Bob and I am 35 years old. My friends are John, Mary."
  