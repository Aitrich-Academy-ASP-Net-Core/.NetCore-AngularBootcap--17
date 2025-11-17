export class User {
    username: string;
    password: string;
    firstName: string;
    lastName: string;
    gender: string;
    phone: string;

    constructor(username: string, password: string, firstName: string, lastName: string, gender: string, phone: string) {
        this.username = username;
        this.password = password;
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.phone = phone;
    }
}
