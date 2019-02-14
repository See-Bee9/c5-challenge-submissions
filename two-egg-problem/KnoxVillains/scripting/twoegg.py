import sys,math;t,b,l=int(sys.argv[1]),int(sys.argv[2]),0;s=int(math.sqrt(1+(8*t))/2);r,e=t-((s*(s+1))/2),t+1;p=False;f=s
while(f<t):
 if f>=b:
  e=f;print f,"\nTrue";break
 print f,"\nFalse";l=f
 if s==r and not p:
  p=True
 else:
  s-=1
 f+=s
for f in range(l+1,e):
 if f>=b:
  e=f;print f,"\nTrue";break
 print f,"\nFalse"
print"Floor",e