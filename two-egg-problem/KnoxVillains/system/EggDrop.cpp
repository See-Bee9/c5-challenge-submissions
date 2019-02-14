#include<cstdlib>
#include<cstdio>
#include<cmath>
I main(I,C*V[]){C z[2400000],t[11]="%llu\nTrue\n",y[12]="%llu\nFalse\n";U o=0,N=g(V[1]),A=g(V[2]),l=0,e=N+1,s=m((S(1+(8*N))-1)/2),r=(N-((s*(s+1))/2));B f=F;X(U W=s;W<N;W+=s){Q(W>=A){o+=k(z+o,t,W);e=W;K;}o+=k(z+o,y,W);l=W;s-=(((s==r)&&!f)?[&f](){f=T;O 0;}():1);}X(U W=(l+1);W<e;++W){Q(W>=A){o+=k(z+o,t,W);e=W;K;}o+=k(z+o,y,W);}p("%sFloor %llu\n",z,e);}