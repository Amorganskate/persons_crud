<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
  </div>
</template>

<script>
// @ is an alias to /src

export default {
  name: "about",
  components: {},
  methods() {
    {
      fetch("/api/get_people")
        .then(data => console.log(data))
        .catch(error => console.log(error));
    }
  },
  created() {
    this.get_people();
  }
};
</script>
