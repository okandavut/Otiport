import { createStore, applyMiddleware, compose } from "redux";
import thunk from "redux-thunk";
import { createLogger } from "redux-logger";
import { persistStore, persistReducer } from "redux-persist";
import storage from "redux-persist/lib/storage";
import reducers from "../reducers";

const persistConfiguration = {
  key: "root",
  storage: storage
};

<<<<<<< HEAD
let persistorReducer  = persistReducer(persistConfiguration, reducers);
=======
const persistorReducer = persistReducer(persistConfiguration, reducers);
>>>>>>> cad88298972590414e9fd53b5f72e93f7a88301e
const logger = createLogger({});

export default function configureStore(onComplete: () => void): any {
  const reduxCompose = compose(applyMiddleware(thunk, logger));
  const store = createStore(persistorReducer, reduxCompose);
  let storePersistor = persistStore(store);

  return { store, storePersistor };
}
