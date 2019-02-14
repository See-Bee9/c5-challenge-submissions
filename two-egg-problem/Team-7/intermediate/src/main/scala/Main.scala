 import scala.math._

object Main extends App {
  var n = args(1).toInt
  var g = ceil(sqrt(args(0).toDouble)).toInt
  var i = 0
  
  val f = (p:Int) => {
    do {
      i += p
      println(s"$i\n${i >= n}")
    } while(i < n)
  }
  f(g)
  i -= g
  f(1)
  println(s"Floor $i")
}