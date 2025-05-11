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
