// Create a new Windows Form application.
// Add a Timer control to the form.
// Set the Timer's Interval property to 1000 (1 second).
// Double-click the Timer control to open its event handler.
// Add the following code to the event handler:

using System;

private void timer1_Tick(object sender, EventArgs e)
{
    // Get the current time.
    DateTime now = DateTime.Now;

    // Update the form's Text property with the current time.
    this.Text = now.ToString("h:mm:ss tt");
}

// Start the Timer.
timer1.Start();
