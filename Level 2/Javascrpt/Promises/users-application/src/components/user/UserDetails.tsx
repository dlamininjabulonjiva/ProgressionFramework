import { getUserData } from "@src/services/users-service";
import { useEffect, useState } from "react";
import { User } from "./UserModel";

const UserDetails: React.FC = () => {
    const [users, setUsers] = useState<User[]>([]);
    
    useEffect(() => {
        getUserData().then((users: User[]) => setUsers(users));
    }, []);

    if (!users) return <div>Loading...</div>;

    return (
        <>
            {users && users.map((user: User) => {
                return <div key={ user.id } className="max-w-md mb-3 p-2 mx-auto bg-white rounded-xl shadow-md overflow-hidden md:max-w-2xl">
                        <div className="md:flex">
                            <div className="p-8">
                                <div className="uppercase tracking-wide text-sm text-green-400 font-semibold">
                                    Name: { user.name }
                                </div>
                                <div
                                    className="uppercase tracking-wide text-sm text-blue-600 font-semibold mt-2"
                                >
                                    Email: { user.email }
                                </div>
                                <div
                                    className="uppercase tracking-wide text-sm text-lime-700 font-semibold mt-2"
                                >
                                    Phone Number: { user.email }
                                </div>
                                <p className="uppercase tracking-wide text-sm text-purple-900 font-semibold mt-2">
                                    Username: { user.username }
                                </p>
                            </div>
                        </div>
                    </div>;
            })}
        </>
    );
}

export default UserDetails;