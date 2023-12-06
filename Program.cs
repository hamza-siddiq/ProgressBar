namespace Program{
    /*
    * Implementation of a Progress bar inside a loop
    */
    count = 30
    var progressbar = new ProgressBar(count)
    foreach (int i in count){
        tick();
    }
}