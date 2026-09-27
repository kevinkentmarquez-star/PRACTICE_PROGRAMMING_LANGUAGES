#include <iostream>
using namespace std;

int main() {
    double num1, num2, result;
    char op;

    cout<< "Enter a number: ";
    cin>>num1;
    
    cout<< "Enter operator: ";
    cin>>op;

    cout<< "Enter a number: ";
    cin>>num2;

    if(op == '+')
    {
        result = num1 + num2;
        cout<< "The result is: "<<result<<endl;
    }
    else if(op == '-')
    {
        result = num1 - num2;
        cout<< "The result is: "<<result<<endl;
    }
    else if(op == '*')
    {
        result = num1 * num2;
        cout<< "The result is : "<<result<<endl;
    }
    else if(op == '/')
    {
        result = num1 / num2;
        cout<< "The result is: "<<result<<endl;
    }
    else
    {
        cout<< "Please select operator only (+,-,*,/)"<<endl;
    }
    return 0;

} 