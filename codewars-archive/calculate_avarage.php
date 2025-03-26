//Write a function which calculates the average of the numbers in a given list.
//Note: Empty arrays should return 0.
<?php
function find_average($array): float {
    $sum = 0;
    for($x = 0; $x < count($array); $x++){
        $sum += $array[$x];
    }
    if(count($array) == 0){
        return 0;
    }
    return $sum / count($array);
}
?>