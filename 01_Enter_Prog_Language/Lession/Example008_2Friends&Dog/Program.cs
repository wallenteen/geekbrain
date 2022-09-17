int dist=10000;
int friend1speed=1;
int friend2speed=2;
int dogspeed=5;
int count=0;
int friend=2;

while(dist>10){
    int time=0;
    if(friend=1){
        time=dist/(friend1speed+dogspeed);
        int friend=2;
    }
    else{
        time=dist/(friend2speed+dogspeed);
        int friend=1;
    }

    int result=dist-(friend1speed+friend2speed)*time;
    count++;

}
Console.WriteLine(count);