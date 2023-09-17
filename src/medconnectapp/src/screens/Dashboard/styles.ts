import {StyleSheet} from 'react-native';
import {globalMargin} from '../../../theme/global.margin';

export const styles = StyleSheet.create({
  container: {
    backgroundColor: '#FFF',
  },
  header: {},
  content: {
    backgroundColor: '#FFF',
    width: '95%',
    flexDirection: 'column',
    marginHorizontal: globalMargin.marginHorizontal - 10,
    padding: 5,
    paddingTop: 25,
    alignSelf: 'center',
    zIndex: 90,

    shadowColor: '#000',
    shadowOffset: {
      width: 0,
      height: 1,
    },
    shadowOpacity: 0.2,
    shadowRadius: 1.41,

    elevation: 2,

    borderRadius: 2,

    marginTop: -20,
  },
  box: {
    height: 300,
    backgroundColor: '#DDD',
    margin: 7,
    borderRadius: 5,
  },
});
