import { User } from "@src/components/user/UserModel";

export const getUserData = async (): Promise<User[]> => {
    return new Promise<User[]>((resolve, reject) => {
      fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(users => {
          const userArray = users.map((user: User) => ({
            id: user.id,
            name: user.name,
            email: user.email,
            phone: user.phone,
            username: user.username,
          }));
          resolve(userArray);
        })
        .catch(error => {
          reject(error);
        });
    });
}