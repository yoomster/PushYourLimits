<template>
  <v-container class="goal-page py-8 px-4" fluid>
    <div class="text-center mb-6">
      <h1 class="text-h4 font-weight-bold basil--text">
        Stel je beweegdoel in
      </h1>
      <h3 class="text-subtitle-1 text-grey-darken-1">
        Zet je in voor een gezondere week!
      </h3>
    </div>

    <div class="mb-6">
      <h3 class="text-subtitle-1 font-weight-medium basil--text">
        Aantal dagen per week
      </h3>
      <v-slider
        v-model="weekGoal"
        :max="6"
        :ticks="days"
        show-ticks="always"
        step="1"
        tick-size="4"
        color="green-darken-2"
        track-fill-color="green-lighten-1"
        track-background-color="grey-lighten-2"
      />
      <div class="text-center font-weight-medium mt-2 orange--text">
        Je kiest voor <strong>{{ days[weekGoal] }}</strong> bewegen per week.
      </div>
    </div>

    <div class="mb-6">
      <h3 class="text-subtitle-1 font-weight-medium basil--text">
        Minuten per actieve dag
      </h3>
      <v-slider
        v-model="minutesPerDay"
        :min="10"
        :max="120"
        :ticks="minutes"
        show-ticks="always"
        step="10"
        tick-size="4"
        thumb-label="always grey-lighten-2"
        color="green-darken-2"
        track-fill-color="green-lighten-1"
        track-background-color="grey-lighten-2"
      />
      <div class="text-center font-weight-medium mt-2 orange--text">
        Doel: <strong>{{ minutesPerDay }}</strong> minuten bewegen per actieve
        dag.
      </div>
    </div>

    <div class="text-center font-weight-medium mt-2 orange--text">
      <p class="goal-summary text-center my-6 orange--text">
        Je totale doel is <strong>{{ days[weekGoal] }} </strong> per week actief
        te zijn, met telkens
        <strong>{{ minutesPerDay }} minuten</strong> beweging.
      </p>
    </div>

    <div class="text-center">
      <v-btn to="/streak" variant="outlined" class="ok-btn me-3" type="submit">
        Opslaan
      </v-btn>
    </div>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      weekGoal: 0,
      minutesPerDay: 10,
    };
  },
};
</script>
<script setup>
const days = {
  0: "1 dag",
  1: "2 dagen",
  2: "3 dagen",
  3: "4 dagen",
  4: "5 dagen",
  5: "6 dagen",
  6: "7 dagen",
};
</script>

<style>
.basil--text {
  color: #356859 !important;
}
.orange--text {
  color: #ff983d !important;
}

.v-slider {
  margin-top: 16px;
  /* track-color: #356859; */
  color: #356859;
}
.goal-summary {
  font-size: 1.1rem;
  background-color: #f4ede6;
  padding: 12px 16px;
  border-radius: 8px;
  display: inline-block;
}
</style>
