package main

import (
	. "fmt"
	. "math"
	. "os"
	. "strconv"
)

func main() {
	n, _ := Atoi(Args[2])
	v, _ := Atoi(Args[1])
	g, i := int(Ceil(Sqrt(float64(v)))), 0

	f := func(p int) {
		for i < n {
			i += p
			Printf("%d\n%t\n", i, i >= n)
		}
	}
	f(g)
	i -= g
	f(1)
	Printf("Floor %d", i)
}