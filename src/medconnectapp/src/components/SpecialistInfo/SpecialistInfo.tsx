import { View, Image, Text, TouchableOpacity } from "react-native"
import { publicFiles } from "../../../config/env"
import { styles } from "./Styles"
 

type CardData = {
    fotoPerfil: string,
    nome: string,
    sobrenome:string,
    descricaoCurta:string,
    categoria:string,
    atendimentos:object,
}

export const SpecialistInfo = (Prop : CardData) => {

  return (
    <View style={styles.container}>
        <View style={styles.cardSpecImgContainer}>
             <Image style={styles.cardSpecImgProfile} source={{uri:`${publicFiles}/${Prop.fotoPerfil}`}} />
        </View>
        <View style={styles.cardSpecInfo}>
            <Text style={styles.cardTextInfo}>{Prop.nome} {Prop.sobrenome} </Text>
            <Text style={styles.cardTextInfo}>{ Prop.descricaoCurta }</Text>
            <Text style={styles.cardTextInfo}>{Prop.categoria}</Text>
        </View>
    </View>
  )
}
