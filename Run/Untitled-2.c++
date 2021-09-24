#include <iostream>

long BixFunction(int x, int y = 5, float z = 5)
{
    return(++x * ++y + (int)++z);
}

void main(){
    Std::cout << BixFunction(10, 20);
    return 0;
}