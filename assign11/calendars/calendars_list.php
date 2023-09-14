<?php include '../view/header.php'; ?>
<main>
   <section>
       <h1>All Calendar Entries</h1>
       <table style="border: 1px solid black">
       <tr>
        <td>Event Name</td>
        <td>Event Start Time</td>
        <td>Event Location</td>
        <td>Attendance Probability</td>
        </tr>
       <?php foreach ($calendars as $calendar) :?>
           <tr>
            <td><?=$calendar['event_name']?></td>
            <td><?=$calendar['start_time']?></td>
            <td><?=$calendar['event_location']?></td>
            <td><?=$calendar['attend_probability']?></td>
           </tr>
       <?php endforeach; ?>
       </table>
       <?php //var_dump($books); ?>
   </section>
</main>
<?php include '../view/footer.php'; ?>
