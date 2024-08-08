<html>   
    <img src="https://miro.medium.com/v2/resize:fit:1200/1*KR1fNNw974TBiVymp7UGOQ.png" alt="Square wave" width="300"  align="right">
      <h1>Magic Box </h1>
      <p>In this repository you will find an implementaton of the <b>Magic Box</b> which is a square matrix whose rows and columns are in 
      <b>ODD</b> numbers, it is called by that name because when adding the numbers of a row and the numbers of a column they will be equal
      and also when adding the numbers in diagonal they will also give the same number.</p>
      <br>
      <h4>Algorithm</h4>
      <p>The algorithm is so simple. You will first place the number 1 at the center of the first row(row = 1 , column = 2). Then, ask yourself if the next number (which is 2 in our case) is divisible by 3. If it is, increase the row by one(row = 2 , column = 2); if not, you need to decrement both the row and the column by one(row = 3 , column = 1),remember that if the row or column number become zero then we need to go ot maximum value(which is 3 in our example). And that's it.</p>

</html>
