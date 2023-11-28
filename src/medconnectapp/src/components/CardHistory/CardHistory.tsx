import {View, Text, Image, TouchableOpacity, Alert} from "react-native"
import { publicFiles } from "../../../config/env"
import { IConsulta, IEspecialista } from "../../api/interfaces"
import {Consulta} from "../../api"
import { styles } from "./Styles"

import { useNavigation } from "@react-navigation/native"
import { useAuth } from "../../hooks/useAuth"

type Prop = {
  consulta:IConsulta,
  especialista:IEspecialista
}

const consultaController = new Consulta();

export const CardHistory = ({consulta, especialista}: Prop) => {
  const {token} = useAuth();
  const navigation = useNavigation() 
    
  const cancel = async(consultaId: string) => {
    try{

      const response = await consultaController.cancel(consultaId , token)
      console.log("RESposta ",response)
      

    }catch(error){
      console.log(error)
    }
  }

  const cancelarConsulta = (consultaId: string) => {
    Alert.alert('Cancelar Consulta', 'Tem certeza que deseja cancelar esta consulta?', [
      {
        text: 'Não Cancelar',
        onPress: () => {},
        
      },
      {
        text: 'Cancelar Consulta', 
        onPress: () => cancel(consultaId)},
    ]);
  }

  return (
    <View>
     { 
      especialista && consulta ?   
        (
        <View style={styles.cardContainer}>
            <View  style={styles.cardContainer.image}>
                
                <Image 
                      source={{uri:`${publicFiles}/${especialista.fotoPerfil}`}}
                      style={styles.cardContainer.image.fotoPerfil}
                      resizeMode="contain"
                />
          </View>
            <View>
              <Text>Profissional: {especialista.nome}</Text>
              <Text>Especialidade: {"Cirurgia Bareatrica"}</Text>
              <Text>Data: {consulta.dataConsulta.split("T")[0]}</Text>
              <Text>Hora: {consulta.dataConsulta.split("T")[1]}</Text>
            </View>

          {
            consulta.isAtiva ? (
          <>
            <TouchableOpacity onPress={()=> navigation.navigate("AppointmentCall",{especialista:especialista})} style={styles.cardContainer.cardSpecBtnView}>
                <Text style={styles.cardContainer.cardSpecBtnViewText}>Visualizar</Text>
            </TouchableOpacity>
            <TouchableOpacity 
             onPress={() => cancelarConsulta(consulta.consultaId)}
             style={[styles.cardContainer.cardSpecBtnView,  {backgroundColor: "#942e2e"}]}>
                <Text style={styles.cardContainer.cardSpecBtnViewText}>Cancelar</Text>
            </TouchableOpacity> 
          </>
            ) : <><Text style={styles.cardContainer.cancelada }>
                   Cancelada
                   </Text>
                </>
          }
           </View>
          )
          :
          (
            <View><Text>Nenhuma consulta agendada...</Text></View>            
          )
      }

    </View>
  )
}
