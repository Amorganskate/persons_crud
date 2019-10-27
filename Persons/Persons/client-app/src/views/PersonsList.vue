<template>
  <div>
      <v-data-table :headers="headers" :items="people" item-key="id" show-select :search="search">
          <template v-slot:items="props">
              <td>{{props.item.age}}</td>
              <td>{{props.item.eye_color}}</td>

              <td>{{props.item.hair_color}}</td>
          </template>
      </v-data-table>
  </div>
</template>

<script>
    let personsList = {
        data: () => ({
            people: [],
            headers: [
                {
                    text: 'Age',
                    sort: false,
                    value: 'age'
                },
                {
                    text: 'Eye Color', 
                    sort: false,
                    value: 'eye_color'
                },
                
                {
                    text: 'Hair Color',
                    sort: false,
                    value: 'hair_color'
                }
            ],
            search: '',
        }),
        methods: {

            get_people: function () {

                fetch("/api/people")
                    .then((resp) => resp.json())
                    .then(data => {
                        console.log(data.data)
                        this.people = data;
                    })
                    .catch(error => console.log(error));
            }

        },
        created() {
            this.get_people();
        }
    };
export default personsList;
</script>
