int main()
{
    int arr[]={56,78,94,56,73,42,31,67};
//Array declaration and initialization
    int total=0,i;//variable declaration
    for(i=0; i<=7; i++){
        total=total+arr[i];//loop for calculatin total
    }
    double avg=total/i;//calculate average
    printf("The average is:%.2f ",avg);
    getch();//display result on the screen
    return 0;