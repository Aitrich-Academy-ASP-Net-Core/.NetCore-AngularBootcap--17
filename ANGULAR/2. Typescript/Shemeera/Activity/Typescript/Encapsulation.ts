class BankAccount{

    private Accountnumber:number;
    private Balance:number;


    constructor(Accountnumber:number,Balance:number=0)
    {
this.Accountnumber=Accountnumber;
this.Balance=Balance;

    }



public deposit(amount:number):void{

    if(amount>0){
        this.Balance+=amount;
        console.log(`deposited${amount},current balance is ${this.Balance}`)
    }else{

        console.log("ivalied")
    }
}

 public widraw(amount:number):void{

    if(amount>0 && amount<=this.Balance)
    {
           this.Balance -= amount;
        console.log(`Widrawn${amount},current balance is ${this.Balance}`)
}else{
    console.log("invalied")
}
}


public getBalance(): number {
    return this.Balance;
  }

}

let b1=new BankAccount(1457855455,7000);
b1.deposit(1000);
b1.widraw(2000);
console.log("Final Balance:", b1.getBalance());





// activity2 ;studentmark


class studentMark{

    private name:string;
    private mark:number=0;

    constructor(name:string)
    {
        this.name=name;


    }

public settermark(mark:number):void{

    if (mark>0 && mark<=100){
        this.mark=mark;
    }else{
        console.log("invalied mark")
    }

}

public getttermark():void{
    if(this.mark>=90)
        {
            console.log("Garade :A");
        }
else if(this.mark>=80){
    
   console.log("Garade :B");

}
else if(this.mark>=70){
    
   console.log("Garade :c");

}
else if(this.mark>=60){
    
   console.log("Garade :D");

}
else {
    
   console.log("Failed");

}

}

}

let stud= new studentMark("meera");
stud.settermark(85);
stud.getttermark();



// activity3 employeesalary


class Employees{

    private Empname:string;
    private Salary:number;
     constructor(Empname:string,salary:number){

this.Empname=Empname;
this.Salary=salary;
}
public settersalary(perfomence:string):void{

    if(perfomence== "good"){

        this.Salary+=5000;

    console.log(`${this.Empname}'s performance is good! Salary increased to ₹${this.Salary}`);
    } else {
      console.log(`${this.Empname}'s performance is not good. Salary remains ₹${this.Salary}`);
}

}
public gettersalary():void{
//    return this.Salary;

console.log(`current salary${this.Salary}`)
}


}

let E1= new Employees("meera",10000);
E1.settersalary("good");
E1.gettersalary();



// activity4 PRODUCT

class Products{
    private Productname:string;
    private Productprice:number;
    private Discount:number=0;


    constructor(Productname:string,Productprice:number){

        this.Productname=Productname;
        this.Productprice=Productprice;
    }

    public setterdiscount(Discount:number):void{

        if (Discount>0 && Discount<50){

   this.Discount=Discount;
   }else{

    console.log(" Discount cannot be more than 50%! Setting it to 50%.");
  }

    }



public getterdiscount():void{
let getFinalPrice=this.Productprice - (this.Productprice * this.Discount) / 100;
 console.log(` Product: ${this.Productname}`);
    console.log(` Price: ₹${this.Productprice}`);
    console.log(` Discount: ${this.Discount}%`);
    console.log(` Final Price after discount: ₹${getFinalPrice}`);
    console.log("-------------------------------------");

}
}


let p1=new Products("rice",400);
p1.setterdiscount(55);
p1.getterdiscount();