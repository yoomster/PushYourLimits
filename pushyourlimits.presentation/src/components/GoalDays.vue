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
      <h3 class="text-subtitle-1 font-weight-medium orange--text">
        Aantal dagen per week
      </h3>
      <v-slider
        v-model="weekGoal"
        :max="6"
        :ticks="days"
        show-ticks="always"
        step="1"
        tick-size="4"
        track-color="basil"
        color="basil"
      />
      <div class="text-center font-weight-medium mt-2">
        Je kiest voor <strong>{{ days[weekGoal] }}</strong> bewegen per week.
      </div>
    </div>

    <div class="mb-6">
      <h3 class="text-subtitle-1 font-weight-medium orange--text">
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
        track-color="basil"
        color="basil"
      />
      <div class="text-center font-weight-medium mt-2">
        Doel: <strong>{{ minutesPerDay }}</strong> minuten bewegen per actieve
        dag.
      </div>
    </div>

    <v-alert
      type="info"
      class="text-center mb-6"
      color="orange-lighten-4"
      border="start"
      border-color="orange"
      icon="mdi-shoe-print"
      variant="tonal"
    >
      Je totale doel is <strong>{{ weekGoal + 1 }} dagen</strong> per week
      actief te zijn, met telkens
      <strong>{{ minutesPerDay }} minuten</strong> beweging.
    </v-alert>

    <div class="text-center">
      <v-btn to="/streak" variant="flat" class="ok-btn" type="submit">
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
      minutesPerDay: 0,
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
  color: #f4a259 !important;
}

.v-slider {
  margin-top: 16px;
}
</style>
