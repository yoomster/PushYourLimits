<template>
  <v-app>
    <NavBar></NavBar>
    <v-main>
      <router-view />
    </v-main>
    <Footer></Footer>
  </v-app>
</template>

<script setup>
import Footer from "./components/AppFooter.vue";
import NavBar from "./components/AppNavBar.vue";
</script>

<style>
body .v-application,
.v-main {
  background-color: #ffffff !important;
  margin: 0;
  padding: 0;
}

.page-wrapper {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

.v-main {
  flex: 1;
}
</style>
