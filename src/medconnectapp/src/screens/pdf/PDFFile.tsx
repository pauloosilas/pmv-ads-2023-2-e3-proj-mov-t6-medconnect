import Pdf from "react-native-pdf"


export const PDFFile = () => {
    const source = { uri: 'http://samples.leanpub.com/thereactnativebook-sample.pdf', cache: true };
  return(
      <Pdf
        source={source}
        trustAllCerts={false}         
        style={{ width: "100%", height: "100%"}}     
    />
  )
   
}
