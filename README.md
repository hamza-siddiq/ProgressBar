# ProgressBar
A progress bar in C#
It takes in a required argument of total count, as well as optional arguments like the style of progressbar, or number of sticks to use.


Example Implementation:
`
int count = 30;
var progressbar = new ProgressBar(count);
for (var i = count; i > 0; i--){
  progressbar.Tick();
}
`
<img width="247" alt="Screenshot 2023-12-06 at 12 37 29 PM" src="https://github.com/hamza-siddiq/ProgressBar/assets/92462002/dc274db3-dc5f-4a0d-af94-a62b2e9acb6a">
